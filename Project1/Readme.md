https://localhost:44465/  FE
https://localhost:44465/weatherforecast  get

https://localhost:<port>/swagger/index.html

https://localhost:7054/api/todoItems get

GET /api/todoitems	Get all to-do items	None	Array of to-do items
GET /api/todoitems/{id}	Get an item by ID	None	To-do item
POST /api/todoitems	Add a new item	To-do item	To-do item
{
  "name": "walkhjghj ",
  "isComplete": true
}
PUT /api/todoitems/{id}	Update an existing item  	To-do item	None
{
    "id": 2,
  "name": "walkhjghj ",
  "isComplete": true
}
DELETE /api/todoitems/{id}    	Delete an item    	None	None

https://localhost:7054/home
