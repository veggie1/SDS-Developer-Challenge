import React, { useState } from 'react';
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
    const [loginAttempts, setLoginAttempts] = useState([]);

    const handleSubmit = ({ login, password }) => {
        const newAttempts = [...loginAttempts, { login, password }];

        setLoginAttempts(newAttempts);
    };

    return (
        <div className='App'>
            <LoginForm onSubmit={handleSubmit} />
            <LoginAttemptList attempts={loginAttempts} />
        </div>
    );
};

export default App;
