import React from 'react';
import './TaskItem.css';
import TaskDate from './TaskDate';
const TaskItem = (props) => {

    return (
        <div className='expense-item'>
            <TaskDate date={props.date} />
            <div className='expense-item__description'>
                <h2>{props.task_name}</h2>
                <div className='expense-item__price'>{props.task_category}</div>
                <div className='expense-item__price' >{props.task_creator}</div>
            </div>

        </div>
    )

}
export default TaskItem;