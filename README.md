# tonicAPI

Simple To-Do list API using .NET framework with a SQL database that tracks progress of each item (true = complete and false = not complete)
## Endpoints 

- ``` GET api/ToDoItems ```
  * returns list of all to do items

- ``` GET api/ToDoItems/{id} ```
  * returns to do item based on ID passed in

- ``` DELETE api/ToDoItems/{id} ```
  * deletes to do item based on ID passed in

- ``` PUT api/ToDoItems ```
  * updates item based on id in json body:
    * "{"id":1,"itemName":"create to-do API","itemStatus":true}"

 - ``` POST api/ToDoItems ```
    * adds item based on object in json body:
      * "{"itemName":"create to-do API","itemStatus":true}"
