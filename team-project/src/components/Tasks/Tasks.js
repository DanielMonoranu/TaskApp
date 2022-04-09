import React, { useState } from 'react';
import TaskItem from './TaskItem';
import './Tasks.css';

const Tasks = (props) => {


    return (
        <div>
            <div className='expenses'>

                {props.items.map((task) => (
                    <TaskItem
                        date={task.date}
                        task_name={task.task_name}
                        task_category={task.task_category}
                        task_creator={task.task_creator}

                    />
                ))}
            </div>
        </div>
    );
};
export default Tasks;