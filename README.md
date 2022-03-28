# Restaurant

The group has decided to create a game which simulates a restaurant. The idea is that the user manages a restaurant by having to take orders, cook the food, have the food brought by a waiter to the customer and complete the order by receiving your pay.   

As for the UI framework, we will be using UWP. 

By means of multi-threading we’ll have the application run different threads for the tasks of taking orders, cooking the food and preparing the drinks, bringing the order and completing the order by receiving the payment. 

By using a thread pool we can the tasks executed by the workers of the restaurant, the cook, barman and waiter. 

By using mutex we can check if the seats in the restaurant are occupied or not and if so, place a customer on the free seats. 

By using async/await the waiter can take new orders and guide customers to open seats while the barman and cook prepare the food and drinks for existing orders. 

As for version control, we will be using GitHub. For developing the game, we will be using C# and the latest version of visual studio. 
