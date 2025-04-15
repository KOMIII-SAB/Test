script.sql
Table creation scripts: Defines all database tables with their respective columns, data types, and constraints.

Stored procedures: Implements the core database logic used by the application, including data retrieval, 
insertion, updates, and deletions.

Web -> Backend -> Server.js
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
database configuration

const workingDirectory = "Location\\Test\\Main\\bin\\Debug\\net9.0-windows";
location of the Main.exe file

.Net Main solution
db folder - StoredProcedureClasses
Shared connectionString As String = "Server=; Database=Test; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"


backend in terminal run npm install

react-login in terminal run npm install
