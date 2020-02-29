# Pierre's Bakery

#### _Code Review for Week 8 - 2/28/2020_

#### _By Jonathan Carlos_

## **Description**

_This application will build a C# codebase for Pierre's Bakery. It will greet and allow a user to choose whether or not they would like to purchase hearty loaves of bread or tasty pastries. Before choosing what to purchase, the user will be also be prompted a special offer for buying multiple loaves of bread, or multiple pastries that are available only at Pierre's Bakery!_

## Preview

<img src= "./img/preview_image.jpg">

## **Behavior Driven Development**

| Behavior | Input | Output |
|----------|:-----:|--------|
| Customer enters "Yes" to decide whether or not to purchase bread or pastry. | Yes | "Wonderful! Here are today's specials. <br> Bread: Buy 2 hearty loaves, get 1 free. <br> Pastry: Buy 1 tasty pastry for $2 or 3 for $5 |
| Customer enters "No" to decide whether or not to purchase bread or pastry. | No | "Thank you for stopping by Pierre's Bakery!" <br> "We hope to see you back soon. Have a nice Day!" |
| Customer enters an amount for a hearty loaf of bread. | 1 | $5, 1 hearty loaf. |
| Customer enters an amount for a single tasty pastry. | 1 | $2, 1 tasty pastry. |
| Customer enters an amount for 2 hearty loaves of bread. | 2 | $10, 3 hearty loaves. |
| Customer enters an amount for 3 tasty pastries. | 3 | $5, 3 tasty pastries. |
| Customer enters an amount for both bread and pastry. | 2, 3 | $15, 2 hearty loaves and 3 tasty pastries. |

## **Minimum Viable Product (MVP)**

The MVP of this application is to allow potential customers to choose whether or not they would like to purchase anything, see the day's specials, choose the amount of bread and/or pastry they would like, and see that in their detailed order information as well as the total of their order.

Stretch goals include:

* Allow potential customers to buy different kinds of Bread and Pastries.
* Add additional deals that fall on different days of the week.
* Allow potential customers to continue adding to their cart/order.

## **Setup/Installation**

*Cloning this repository:*
1. Open up your terminal.
2. Navigate to the desired directory in which you want to clone this repository.
3. Use the command `git clone https://github.com/jonathancarlos21/Pierres-Bakery` to clone this repository.
4. Open this repository from within your terminal.
5. Use `dotnet run` to start the application.

*Downloading this repository:*
1. On the top right of this page, click the "Clone or download" button.
2. Click on "Download ZIP."
3. Click the downloaded file to unzip and extract this repository to your desired directory.
4. Within your terminal, navigate to the directory where you saved this repository.
5. Open the repository within your terminal.
6. Use `dotnet run` to start the application.

## **Known Bugs**

There are no known bugs at this time.

## **Support and contact details**

If you have any questions, comments, or concerns, please feel free to contact the content creator at examplemail@company.net 

## **Technologies used**

* C#

* .Net Core

* Visual Studio Code

* GitBash

## **License**

Copyright (c) 2020 **_Pierre's Bakery_**

This software is licensed under the MIT license.