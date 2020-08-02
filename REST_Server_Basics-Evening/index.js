var express = require("express");
var app = express();
var fs = require("fs");
app.use(express.json());

//To  create server in port 3000
app.listen(3000, () => {
    console.log("Server running on port 3000");
   });


const lists=[
    {key: 1,value: "This is the value of key 1"},
    {key: 2,value: "This is the value of key 2"},
    {key: 3,value: "This is the value of key 3 "  },
    {key: 4,value: "This is the value of key 4"}
]


var newList={key: 5,value:"This is List 5" };


app.get('/', (req, res) => {
    res.send('The new Rest API is created.\n\n /todoLists- (GET) use GET to get value of all keys\n\n /todoList/addList- (POST) to add a key value pair\n\n '+
    "/todoLists/key- (GET) to get value of that key (1-4)\n"+"\n /todoLists/id- (PUT) to edit a value and set new value to that key\n"+
    "\n /todoLists/key- (DELETE) to delete the value with that key")
    });


app.get('/todoLists', function (req, res) {
     res.send(lists);
});


app.post('/todoLists/addList', (req, res)=> {
    lists.push(newList);
    res.send(newList);
});


app.get('/todoLists/:key', (req, res) => {
        const list = lists.find(c => c.key === parseInt(req.params.key));
        res.send(list);
});


app.put('/todoLists/edit/:key', (req, res) => {
    const list = lists.find(c=> c.key === parseInt(req.params.key));
    list.value = req.body.value;
    res.send(list);
}); 


app.delete('/todoLists/:key', (req, res) => {
    const list = lists.find( c=> c.key === parseInt(req.params.key));   
    const index = lists.indexOf(list);
    lists.splice(index,1);
    res.send(list);
});