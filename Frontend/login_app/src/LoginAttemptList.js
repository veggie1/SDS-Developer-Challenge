import React, { useState } from 'react';
import './LoginAttemptList.css';

const LoginAttemptList = (props) => {
    const [filteredList, setFilteredList] = useState(props.attempts);

    const handleFilter = (value) => {
        const result = filteredList.attempts.filter((item) => {
            return item.includes(value);
        });

        setFilteredList(result);
    };

    return (
        <div className='Attempt-List-Main'>
            <p>Recent activity</p>
            <input type='input' placeholder='Filter...' />
            <ul className='Attempt-List'>
                {props.attempts.map((attempt) => {
                    console.log('in the map', attempt);
                    return <li>{attempt.login}</li>;
                })}
            </ul>
        </div>
    );
};

export default LoginAttemptList;
