import React, { useEffect, useState } from 'react';
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
    const [loginAttempts, setLoginAttempts] = useState([]);

    const handleSubmit = ({ login, password }) => {
        console.log('made it here');
        console.log('loginAttempts', loginAttempts);

        const newAttempts = [...loginAttempts, { login, password }];
        console.log('newAttempts', newAttempts);

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
