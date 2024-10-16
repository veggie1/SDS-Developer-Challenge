import React, { useState } from 'react';
import './LoginForm.css';

const LoginForm = (props) => {
    const [name, setName] = useState('');
    const [password, setPassword] = useState('');

    const [errorMessage, setErrorMessage] = useState('');

    const handleSubmit = (event) => {
        event.preventDefault();

        if (Boolean(name) && Boolean(password)) {
            props.onSubmit({
                login: name,
                password: password,
            });

            setErrorMessage('');
            setName('');
            setPassword('');
        } else {
            setErrorMessage('Name and Password are required');
        }
    };

    return (
        <form className='form'>
            <h1>Login</h1>

            <label htmlFor='name'>Name</label>
            <input
                type='text'
                id='name'
                value={name}
                onChange={(e) => setName(e.target.value)}
            />

            <label htmlFor='password'>Password</label>
            <input
                type='password'
                id='password'
                value={password}
                onChange={(e) => setPassword(e.target.value)}
            />

            {Boolean(errorMessage) && <p>{errorMessage}</p>}
            <button type='submit' onClick={handleSubmit}>
                Continue
            </button>
        </form>
    );
};

export default LoginForm;
