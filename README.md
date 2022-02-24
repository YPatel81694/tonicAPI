# tonicAPI

Simple To-Do list API using NodeJS framework with a SQL database that tracks progress of each item (true = complete and false = not complete)
## Routes 

- /api/items: GET, POST
  * ``` GET ```
    * returns list of all to do items
  * ``` POST ```
    * adds a todo items with a json item in request body
    * { "itemName":"add to-do item",
        "itemStatus":true
      }
    * will automatically assign id, add date, and update date into database 
- /api/items/:id: GET, PUT, DELETE
  * ``` GET ```
    * returns a specific to-do item based on ID
  * ``` PUT ```
    * updates a specific to-do item based on ID - requires a json to-do item in request body
  * ``` DELETE ```
    * deletes a specific to-do item based on ID      
