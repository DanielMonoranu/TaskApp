import React from 'react';
import TaskForm from './TaskForm';
import './NewTask.css';

const NewTask = (props) => {

    const saveTaskDataHandler = (enteredTaskData) => {
        const taskData = {
            ...enteredTaskData

            //id ?
        };
        props.onAddTask(taskData);

    }
    return (
        <div className='new-expense'>
            <TaskForm onSaveTaskData={saveTaskDataHandler} />
        </div>
    );
};

export default NewTask;