import React, { useState } from 'react';
import './TaskForm.css';


const TaskForm = (props) => {
    const [enteredTaskName, setEnteredTaskName]=useState('');
    const [enteredTaskCategory, setEnteredTaskCategory]=useState('');
    const [enteredTaskCreator, setEnteredTaskCreator]=useState('');
    const [enteredTaskDate, setEnteredTaskDate]=useState('');


const taskNameChangeHandler=(event)=>{
    setEnteredTaskName(event.target.value);
}
const taskCategoryChangeHandler= (event)=>{
    setEnteredTaskCategory(event.target.value);
}
const taskCreatorChangeHandler=(event)=>{
    setEnteredTaskCreator(event.target.value);
}
const taskDateChangeHandler=(event)=>{
    setEnteredTaskDate(event.target.value);
}
 
const submitHandler =(event)=>{
    event.preventDefault();

    const taskData={
        task_name:enteredTaskName,
        task_category:enteredTaskCategory,
        task_creator:enteredTaskCreator,
        date:new Date(enteredTaskDate),

    };
    props.onSaveTaskData(taskData);
    setEnteredTaskName('');
    setEnteredTaskCategory('');
    setEnteredTaskCreator('');
    setEnteredTaskDate('');

};


    return (
        <form onSubmit={submitHandler} >
            <div className='new-expense__controls'>
                <div className='new-expense__control'>
                    <label>Name:</label>
                    <input
                        type='text'
                        value={enteredTaskName}
                        onChange={taskNameChangeHandler}
                    />
                </div>
                <div className='new-expense__control'>
                    <label>Category:</label>
                    <input type='text'
                        value={enteredTaskCategory}
                        onChange={taskCategoryChangeHandler}
                    />
                </div>
                <div className='new-expense__control'>
                    <label>User:</label>
                    <input type='text'
                        value={enteredTaskCreator}
                        onChange={taskCreatorChangeHandler}
                    />
                </div>
                <div className='new-expense__control'>
                    <label>Date</label>
                    <input
                        type='date'
                        min='2022-01-01'
                        max='2023-01-01'
                       value={enteredTaskDate}
                       onChange={taskDateChangeHandler}
                    />

                </div>
            </div>
            <div className='new-expense__actions'>
                <button type='submit'>Add Task</button>
            </div>
        </form>
    );
};
export default TaskForm;