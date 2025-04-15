import { useState, useEffect } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';
import './App.css'; 

function Login() {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const navigate = useNavigate();

  
  useEffect(() => {
    const session = sessionStorage.getItem('userSession');
    if (session) {
      navigate('/dashboard');
    }
  }, [navigate]);

  const handleLogin = async () => {
    console.log('Attempting login');
    try {
      const res = await axios.post('http://localhost:5000/api/login', { username, password });
      if (res.data.success) {
        sessionStorage.setItem('userSession', JSON.stringify({ username }));
        navigate('/dashboard');
      }
    } catch (err) {
      alert('Login failed');
      console.error(err);
    }
  };

  return (
    <div className="login-container">
      <div className="login-form">
        <h2>Login</h2>
        <input 
          type="text" 
          className="input-field" 
          placeholder="Username" 
          onChange={e => setUsername(e.target.value)} 
        />
        <input 
          type="password" 
          className="input-field" 
          placeholder="Password" 
          onChange={e => setPassword(e.target.value)} 
        />
        <button className="login-btn" onClick={handleLogin}>Login</button>
      </div>
    </div>
  );
}

export default Login;
