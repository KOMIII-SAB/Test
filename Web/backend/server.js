const express = require('express');
const bodyParser = require('body-parser');
const sql = require('mssql');
const cors = require('cors');
const { exec } = require('child_process');

const app = express();
app.use(cors());
app.use(bodyParser.json());

const dbConfig = {
    user: '', 
    password: '',  
    server: '',  
    database: 'Test',  
    options: {
        enableArithAbort: true,
        encrypt: true,
        trustServerCertificate: true
    }
};

app.get('/api/ping-db', async (req, res) => {
    try {
        await sql.connect(dbConfig);
        res.json({ success: true, message: 'Connected to SQL Server successfully!' });
    } catch (err) {
        console.error('Database connection failed:', err);
        res.status(500).json({ success: false, message: 'Database connection failed', error: err.message });
    }
});

app.get('/api/users', async (req, res) => {
    try {
        await sql.connect(dbConfig);
        const result = await sql.query('SELECT * FROM Users');
        res.json(result.recordset); // Send back array of users
    } catch (err) {
        console.error('Error fetching users:', err);
        res.status(500).json({ success: false, message: 'Failed to fetch users', error: err.message });
    }
});

app.post('/api/login', async (req, res) => {
    const { username, password } = req.body;
    console.log('Login request received:', username, password);  // Log the incoming credentials

    try {
        await sql.connect(dbConfig);
        console.log('Connected to the database successfully');  // Confirm DB connection

        const result = await sql.query(`SELECT * FROM Users WHERE username = '${username}' AND password = '${password}'`);
        console.log('Query result:', result.recordset);  // Log the result of the query

        if (result.recordset.length > 0) {
            res.json({ success: true });
        } else {
            res.status(401).json({ success: false, message: 'Invalid credentials' });
        }
    } catch (err) {
        console.error('Error during login:', err);
        res.status(500).send('Server error');
    }
});


app.post('/api/launch', (req, res) => {
    const { module } = req.body;
    const moduleArg = module?.toLowerCase();

    if (moduleArg !== 'finance' && moduleArg !== 'operations') {
        return res.status(400).json({ success: false, message: 'Invalid module' });
    }

    const command = `Main.exe ${moduleArg}`;

    const workingDirectory = "E:\\.Net projects\\Test\\Main\\bin\\Debug\\net9.0-windows";

    exec(command, { cwd: workingDirectory }, (err, stdout, stderr) => {
        if (err) {
            console.error(`Error launching app:`, err);
            return res.status(500).json({
                success: false,
                message: `Failed to launch ${module} application`,
                error: err.message
            });
        }
    });
});

const PORT = 5000;
app.listen(PORT, () => console.log(`Server running on port ${PORT}`));
