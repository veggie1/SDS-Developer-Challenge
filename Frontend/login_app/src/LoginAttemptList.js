import React, { useEffect, useState } from 'react';
import './LoginAttemptList.css';

const LoginAttemptList = (props) => {
    const [filteredList, setFilteredList] = useState(props.attempts);
    const [filterValue, setFilterValue] = useState('');

    useEffect(() => {
        setFilteredList(props.attempts);
        setFilterValue('');
    }, [props.attempts]);

    useEffect(() => {
        if (!filterValue) {
            setFilteredList(props.attempts);
        }

        const result = props.attempts.filter((item) => {
            return item.login.includes(filterValue);
        });

        setFilteredList(result);
    }, [filterValue]);

    return (
        <div className='Attempt-List-Main'>
            <p>Recent activity</p>
            <input
                type='input'
                placeholder='Filter...'
                onChange={(e) => setFilterValue(e.target.value)}
            />
            <ul className='Attempt-List'>
                {filteredList.map((attempt, index) => {
                    return <li key={index}>{attempt.login}</li>;
                })}
            </ul>
        </div>
    );
};

export default LoginAttemptList;
