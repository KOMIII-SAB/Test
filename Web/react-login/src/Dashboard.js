import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

function Dashboard() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const navigate = useNavigate();

  useEffect(() => {
    const session = sessionStorage.getItem('userSession');
    if (session) {
      setIsLoggedIn(true);
    } else {
      setIsLoggedIn(false);
      navigate('/');
    }
  }, [navigate]);

  const handleLaunch = async (module) => {
    try {
      await axios.post('http://localhost:5000/api/launch', { module });
      alert(`${module} application launched`);
    } catch (err) {
      alert(`Failed to launch ${module}`);
    }
  };

  const handleLogout = () => {
    sessionStorage.removeItem('userSession');
    setIsLoggedIn(false);
    alert('Logged out successfully!');
    navigate('/');
  };

  const handleLogin = () => {
    sessionStorage.setItem('userSession', 'active');
    setIsLoggedIn(true);
    alert('Logged in successfully!');
  };

  if (!isLoggedIn) {
    return (
      <div style={styles.container}>
        <h2>Please Login</h2>
        <button onClick={handleLogin} style={styles.button}>Login</button>
      </div>
    );
  }

  return (
    <div style={styles.mainContainer}>
      <div style={styles.container}>
        <h2 style={styles.heading}>Welcome to the Dashboard</h2>

        <div style={styles.buttonContainer}>
          <button
            onClick={() => handleLaunch('Finance')}
            style={styles.blueButton}
          >
            Launch Finance
          </button>
          <button
            onClick={() => handleLaunch('Operations')}
            style={styles.blueButton}
          >
            Launch Operations
          </button>
        </div>

        <button
          onClick={handleLogout}
          style={styles.logoutButton}
        >
          Logout
        </button>
      </div>
    </div>
  );
}

const styles = {
  mainContainer: {
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    height: '100vh',
    backgroundColor: '#e5e5e5',
  },
  container: {
    fontFamily: 'Arial, sans-serif',
    textAlign: 'center',
    padding: '20px',
    backgroundColor: '#f7f7f7',
    borderRadius: '8px',
    width: '300px',
    boxShadow: '0px 4px 6px rgba(0, 0, 0, 0.1)',
  },
  heading: {
    color: '#333',
    fontSize: '24px',
    marginBottom: '20px',
  },
  buttonContainer: {
    display: 'flex',
    flexDirection: 'column',
    gap: '10px',
    marginBottom: '20px',
  },
  blueButton: {
    backgroundColor: '#007BFF',
    color: 'white',
    border: 'none',
    padding: '10px 20px',
    fontSize: '16px',
    borderRadius: '5px',
    cursor: 'pointer',
    transition: 'background-color 0.3s',
  },
  logoutButton: {
    backgroundColor: '#f44336',
    color: 'white',
    border: 'none',
    padding: '10px 20px',
    fontSize: '16px',
    borderRadius: '5px',
    cursor: 'pointer',
    transition: 'background-color 0.3s',
  },
  button: {
    backgroundColor: '#007BFF',
    color: 'white',
    border: 'none',
    padding: '10px 20px',
    fontSize: '16px',
    borderRadius: '5px',
    cursor: 'pointer',
  },
};

export default Dashboard;
