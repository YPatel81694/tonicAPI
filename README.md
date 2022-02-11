# tonicAPI

Simple To-Do list API using .NET framework with a SQL database that tracks true (complete) or false (not complete) of each item

## Endpoints 

- Get ``` GET api/ToDoItems ```
  * returns list of all to do items

- Get ``` GET api/ToDoItems/{id} ```
  * returns to do item based on ID passed in

- Delete ``` DELETE api/ToDoItems/{id} ```
  * deletes to do item based on ID passed in

- Put ``` PUT api/ToDoItems ```
  * updates item based on id in json body:
    * "{"id":1,"itemName":"create to-do API","itemStatus":true}"
    
 - Post ``` POST api/ToDoItems ```
    * adds item based on object in json body:
      * "{"id":1,"itemName":"create to-do API","itemStatus":true}"
