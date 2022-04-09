import React, { useState } from "react";
import NewTask from "./components/FormTask/NewTask";
import Tasks from './components/Tasks/Tasks';
import SearchTask from './components/Search/SearchTask';
import DeleteTask from './components/Delete/DeleteTask';

const DUMMY_TASKS = [
  {
    id: "t1",
    task_name: "proiect",
    task_category: 'work',
    task_creator: 'dani',
    date: new Date(2022, 12, 4)
  },
  {
    id: "t2",
    task_name: "thrash",
    task_category: 'house',
    task_creator: 'alex',
    date: new Date(2021, 3, 4)
  },
];

const App = () => {
  //for tasks
  const [tasks, setTasks] = useState(DUMMY_TASKS);

  const addTaskHandler = (task) => {
    setTasks((prevTasks) => {
      return [task, ...prevTasks];
    });
  };

  //for search

  const searchTaskHandler = (task) => {
    console.log(DUMMY_TASKS.task_name);
  }

  // make the form dissapear when the button is pressed
  const [showNewTask, setNew] = useState(false);
  const [showSearch, setSearch] = useState(false);
  const [showDelete, setDelete] = useState(false);

  const [searches, setSearches] = useState('');

  const searchHandler = (enteredTaskData) => {

    //props.onAddTask(taskData);
    console.log("task name " + enteredTaskData.task_name);
    console.log("task category " + enteredTaskData.task_category);
    console.log("task user " + enteredTaskData.task_creator);

  }

  const [searchTerm, setSearchTerm] = useState('');  // pt searchu fake

  return (

    <div>
      <h2>Task app</h2>

      <div>
        <button onClick={() => setNew(prev => !prev)}>Add Task</button>
        {showNewTask && <NewTask onAddTask={addTaskHandler}></NewTask>}

      </div>

      <div>
        <button onClick={() => setSearch(prev => !prev)}>Search</button>
        {showSearch && <SearchTask onSearchTaskData={searchHandler}></SearchTask>}

      </div>

      <div>
        <button onClick={() => setDelete(prev => !prev)}>Delete</button>
        {showDelete && <DeleteTask onAddTask={addTaskHandler}></DeleteTask>}

      </div>
      <Tasks items={tasks} />



    </div>

    /*
        <div>
          <input type='text' placeholder="Search" onChange={event => { setSearchTerm(event.target.value) }} />
          <div>
            {DUMMY_TASKS.filter((val) => {
              if (searchTerm == '') {
                return val
              }
    
              else if (val.task_name.toLocaleLowerCase().includes(enteredTaskData.task_name.toLocaleLowerCase())
              ) { return val }
            }).map((val, key) => {
              return <div>{val.task_name}</div>;
            })}
    
          </div>
       */

  )

}
export default App;