SINGLE PAGE:
server.js:

const express = require ("express");
const mongoose =require("mongoose");
const cors =require("cors");


const app=express();


app.use(cors());
app.use(express.json());


mongoose.connect("mongodb://localhost:27017/userDB")
.then(()=>console.log("Connection made Successfully"))
.catch(err=>console.log(err));


const User =require("./models/User");


// Creating User
app.post("/users", async(req,res)=>{
   try{
       const user= new User(req.body);
       await user.save();


       res.json(user);
   }
   catch(err){
       console.log(err);
       res.status(500).json(err);
   }
});


//Fetch user data
app.get("/users",async (req,res)=>{


   try{
       const users =await User.find();
       res.json(users);
   }
   catch(err){
       res.status(500).json(err);
   }
});


//Update user data
app.put("/users/:id", async(req,res)=>{


   try{


       const user= await User.findByIdAndUpdate(
           req.params.id,
           req.body,
           {new:true}
       );
   res.json(user);
}  
   catch(err){
       res.status(500).json(err);
      }


});


// Delete User
app.delete("/users/:id", async(req,res)=>{
   try{
   await User.findByIdAndDelete(
     req.params.id       
   );
   res.json({
      
       message:"deleted"
   });
}
   catch(err)
   {
       console.log(err);
       res.status(500).json(err);
   }
   });


   app.listen(5000,()=>{
       console.log("Server Running");
   });



User.js:


const mongoose= require("mongoose");


const userSchema = new mongoose.Schema({
   name :String,
   email : String
}
);


module.exports=mongoose.model("User",userSchema);



Client:
App.js:

import React, {useState,useEffect} from "react";
import axios from "axios";
import "./App.css";
function App() {
  const [name,setName]=useState("");
  
const[email,setEmail]=useState("");


const[users,setUsers]=useState([]);


const [editId,setEditId]=useState(null);


const fetchUsers =async()=>{
 const res=await axios.get(
   "http://localhost:5000/users"
 );
 setUsers(res.data);
}


useEffect(()=>{
fetchUsers();
},[]);


const addUser = async()=>{


await axios.post(


"http://localhost:5000/users",


{
name,
email
}


);


fetchUsers();


};


const deleteUser = async(id)=>{


await axios.delete(


`http://localhost:5000/users/${id}`


);


fetchUsers();


};




const updateUser = async()=>{


await axios.put(


`http://localhost:5000/users/${editId}`,


{
name,
email
}


);


setEditId(null);


fetchUsers();


};
 return (


  <div>
     <h1>User Management</h1>


     <input
       type="text"
       placeholder="Name"
       value={name}
       onChange={(e) => setName(e.target.value)}
     />


     <input
       type="email"
       placeholder="Email"
       value={email}
       onChange={(e) => setEmail(e.target.value)}
     />


     <button


onClick={


editId
?
updateUser
:
addUser


}


>


{
editId
?
"Update User"
:
"Add User"
}


</button>


     {
users.map(user=>(


<div key={user._id}>


<h3>{user.name}</h3>


<p>{user.email}</p>


<button
onClick={()=>{


setName(user.name);
setEmail(user.email);
setEditId(user._id);


}}
>
Edit
</button>


<button
onClick={()=>
deleteUser(user._id)
}
>
Delete
</button>


</div>


))
}
   </div>


 );
}




export default App;







____________________________________________________________

Multi Page:


Commands:
mkdir employee-management
cd employee-management
mkdir server
cd server
npm init -y
npm install express mongoose cors nodemon
npx create-react-app client
cd client
npm install axios react-router-dom
Server.js:
const express = require("express");
const mongoose = require("mongoose");
const cors = require("cors");

const Employee = require("./models/Employee");

const app = express();

app.use(cors());
app.use(express.json());

mongoose.connect(
    "mongodb://127.0.0.1:27017/employeeDB"
)
.then(() => {
    console.log("MongoDB Connected");
})
.catch(err => {
    console.log(err);
});


// ADD EMPLOYEE

app.post("/employee", async (req,res)=>{

    try{

        const employee = new Employee({

            name: req.body.name,

            department: req.body.department

        });

        await employee.save();

        res.json(employee);

    }

    catch(error){

        res.status(500).json({
            message:error.message
        });

    }

});


// GET EMPLOYEES

app.get("/employee", async (req,res)=>{

    try{

        const employees =
        await Employee.find();

        res.json(employees);

    }

    catch(error){

        res.status(500).json({
            message:error.message
        });

    }

});


// DELETE EMPLOYEE

app.delete("/employee/:id", async (req,res)=>{

    try{

        await Employee.findByIdAndDelete(
            req.params.id
        );

        res.json({
            message:"Employee Deleted"
        });

    }

    catch(error){

        res.status(500).json({
            message:error.message
        });

    }

});


// UPDATE EMPLOYEE

app.put("/employee/:id", async (req,res)=>{

    try{

        const updatedEmployee =
        await Employee.findByIdAndUpdate(

            req.params.id,

            {
                name:req.body.name,
                department:req.body.department
            },

            {new:true}

        );

        res.json(updatedEmployee);

    }

    catch(error){

        res.status(500).json({
            message:error.message
        });

    }

});

app.listen(5000,()=>{

    console.log("Server Running");

});
models/Employee.js:
const mongoose = require("mongoose");

const employeeSchema = new mongoose.Schema({

    name: String,

    department: String

});

module.exports =
mongoose.model(
    "Employee",
    employeeSchema
);
App.js:
import { BrowserRouter, Routes, Route } from "react-router-dom";

import Home from "./pages/Home";
import AddEmployee from "./pages/AddEmployee";
import ViewEmployees from "./pages/ViewEmployees";
import UpdateEmployee from "./pages/UpdateEmployee";
import DeleteEmployee from "./pages/DeleteEmployee";

function App() {

  return (

    <BrowserRouter>

      <Routes>

        <Route path="/" element={<Home />} />

        <Route
          path="/add"
          element={<AddEmployee />}
        />

        <Route
          path="/view"
          element={<ViewEmployees />}
        />

        <Route
          path="/update"
          element={<UpdateEmployee />}
        />

        <Route
          path="/delete"
          element={<DeleteEmployee />}
        />

      </Routes>

    </BrowserRouter>

  );

}

export default App;

Home.js:
import { Link } from "react-router-dom";

function Home(){

    return(

        <div>

            <h1>
                Employee Management System
            </h1>

            <Link to="/add">
                Add Employee
            </Link>

            <br /><br />

            <Link to="/view">
                View Employees
            </Link>

            <br /><br />

            <Link to="/update">
                Update Employee
            </Link>

            <br /><br />

            <Link to="/delete">
                Delete Employee
            </Link>

        </div>

    );

}

export default Home;
AddEmployee.js:
import { useState } from "react";
import axios from "axios";

function AddEmployee(){

    const [name,setName] =
    useState("");

    const [department,setDepartment] =
    useState("");

    const addEmployee =
    async ()=>{

        await axios.post(
            "http://localhost:5000/employee",
            {
                name,
                department
            }
        );

        alert("Employee Added");

        setName("");
        setDepartment("");

    };

    return(

        <div>

            <h2>Add Employee</h2>

            <input
            placeholder="Name"
            value={name}
            onChange={(e)=>
            setName(e.target.value)}
            />

            <br /><br />

            <input
            placeholder="Department"
            value={department}
            onChange={(e)=>
            setDepartment(e.target.value)}
            />

            <br /><br />

            <button
            onClick={addEmployee}
            >
                Add
            </button>

        </div>

    );

}

export default AddEmployee;
ViewEmployees.js:
import { useState,useEffect }
from "react";

import axios from "axios";

function ViewEmployees(){

    const [employees,
    setEmployees] =
    useState([]);

    useEffect(()=>{

        fetchEmployees();

    },[]);

    const fetchEmployees =
    async ()=>{

        const res =
        await axios.get(
            "http://localhost:5000/employee"
        );

        setEmployees(
            res.data
        );

    };

    return(

        <div>

            <h2>
                Employee List
            </h2>

            {
                employees.map((emp)=>(
                    <div key={emp._id}>

                        <h3>
                            {emp.name}
                        </h3>

                        <p>
                            {emp.department}
                        </p>

                        <hr/>

                    </div>
                ))
            }

        </div>

    );

}

export default ViewEmployees;
UpdateEmployee.js:
import {
useState,
useEffect
}
from "react";

import axios from "axios";

function UpdateEmployee(){

const [employees,
setEmployees] =
useState([]);

const [name,
setName] =
useState("");

const [department,
setDepartment] =
useState("");

const [id,
setId] =
useState("");

useEffect(()=>{

fetchEmployees();

},[]);

const fetchEmployees =
async ()=>{

const res =
await axios.get(
"http://localhost:5000/employee"
);

setEmployees(
res.data
);

};

const updateEmployee =
async ()=>{

await axios.put(

`http://localhost:5000/employee/${id}`,

{
name,
department
}

);

alert("Updated");

};

return(

<div>

<h2>
Update Employee
</h2>

{
employees.map((emp)=>(

<div key={emp._id}>

<p>
{emp.name}
-
{emp.department}
</p>

<button

onClick={()=>{

setId(emp._id);

setName(emp.name);

setDepartment(
emp.department
);

}}

>

Select

</button>

</div>

))
}

<br/>

<input

value={name}

onChange={(e)=>
setName(e.target.value)
}

/>

<br/><br/>

<input

value={department}

onChange={(e)=>
setDepartment(
e.target.value
)
}

/>

<br/><br/>

<button
onClick={updateEmployee}
>

Update

</button>

</div>

);

}

export default UpdateEmployee;
DeleteEmployee.js:
import {
useState,
useEffect
}
from "react";

import axios from "axios";

function DeleteEmployee(){

const [employees,
setEmployees] =
useState([]);

useEffect(()=>{

fetchEmployees();

},[]);

const fetchEmployees =
async ()=>{

const res =
await axios.get(
"http://localhost:5000/employee"
);

setEmployees(
res.data
);

};

const deleteEmployee =
async (id)=>{

await axios.delete(

`http://localhost:5000/employee/${id}`

);

fetchEmployees();

};

return(

<div>

<h2>
Delete Employee
</h2>

{
employees.map((emp)=>(

<div key={emp._id}>

<h3>
{emp.name}
</h3>

<p>
{emp.department}
</p>

<button

onClick={()=>
deleteEmployee(
emp._id
)
}

>

Delete

</button>

<hr/>

</div>

))
}

</div>

);

}

export default DeleteEmployee;
