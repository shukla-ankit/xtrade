
![Xtrade Logo](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/xtrade/xtrade/Content/XTLogo.png)
# XTrade 
   _*Trading made easy*_

## Welcome to XTrade app!
XTrade is a trading platform which can help people buy and sell anything without any hassles. Users can post their ad's, search for and browse various products and buy whatever they like via our app. We have implemented this via ASP.Net MVC framework. We have used various web API's and web services in this project. 

## Business blueprint

[![XTrade](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/video.PNG)](https://www.youtube.com/watch?v=sKQK4Oo1q00)

##Features/Business Rules

###Current

* User is be able to register
* User is able to login via local email or dign in via google 
* User is able to upload images, enter details and post an ad
* User is able to display & edit item name, description, amount, Picture(s) 
* User is able to search items
* User is able to edit items
* User is able to buy an item
* User is able to register a complaint
* Users/Businesses can consume our web service and get all the details of our products

###Future additional functionalities

* User (buyer) should be able to bargain and quote reduced price along with an optional message 
* User (seller) should be able to accept new (reduced) price or reject it along with an optional message 
* Seller should be able to chat with the buyer
* Both buyer and seller should be able to check whether the counter-party has read the message

<iframe width="480" height="311" src="http://www.powtoon.com/embed/drR18NAXiYy/" frameborder="0"></iframe>

### Core Functionality
* Users can browse the products available without logging in. 
* Users can search for the items by entering the key words in the search bar. 
* If a person wants to buy or sell an item, he needs to log-in. 
* After logging in, seller can see his own list of items in a separate page, along with all the items for sale, in another page.
* User can register using his email-ID or he can login via google. Google + API has been used for this functionality.
* After logging in, if user faces any problems or if he has any complaints, he can go to the contact page and register a complaint. An automated Email is sent from the company's google account and all the messages are reviewed by XTrade customer care.
* Sellers can add/edit and delete the products. They can also Add/Edit and Delete multiple images for each of their product listings.
* Buyers clicking on the buy button agree to the price and the terms posted by the seller by default.
* When the buyer clicks on buy button, the product is hidden in the website until the buyer reviews it.
* In case the sale with this buyer fails due to some reason, the product is again shown in the site.
* Businesses can consume our web service and get the details of all our products, their prices, description etc. They can use this to display our products on their websites and this can be used to form partnerships with various businesses.

The following diagram explains the business process.
![Xtrade Logo](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/BP1.png)

## Target Audience
The main target audience are people who want to sell their used goods. Our application is seller driven as most of the control is in the hands of the seller. A seller can either accept or reject the bids of his prospective buyers. Our app also targets the people who want to sell their services, like cleaning service, laundry service etc. The sellers are also a main source of income for our business, which is explained in the monetization section.
A niche segment is also served by our web service. The online portals and businesses can access our web service and get the data of our products.

## Monetization
Our service is relatively new and there is a lot of competetion. So we are not aiming at generating any profits initially. However, some money would be drawn from a paid functionality called as 'premium user'.
When a premium user posts an Ad, his Ad is shown at the top of the search results so that he can reach more number of prospective buyers. A small amount would be charged for premium users annually. They can make the payment via paypal or bank transfer to the specified account number.
We have exposed our web service for use by businesses/individual users. This is provided for free as when other businesses use our web service and access the data of our goods, it can increase our sales tremendously and also increase the popularity of the website, leading to indirect cash flow.

## Screenshots

### Home page of the application:We have made a simple interface.

![Home page](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/homepage.PNG)



###Register using local email account or a google account.

![Registering](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/Register.png)



###Add new items by going to 'post an ad' screen. Also, as seen here, the my items screen shows only items of the user.

![Posting an AD](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/AD.png)



###See all items in the search screen. If the user is premium, his ads are shown first when somebody searches.

![All items screen](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/All%20Items.PNG)



###Search by selecting specific category or all categories. If there are 2 itemscontaining the search term, then they are given preferance based on how close they are to the search term.

![Search](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/Search.PNG)



###Web service can be accessed via the URL as shown below.

![Web Service](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/WebService.png)



###If you have any complaints, you can send us a message via the contact page.

![Complaints](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/Complaints.png)


[![Technical details](https://raw.githubusercontent.com/kiranhsgithub/xtrade/master/screens/Code.PNG)](https://www.youtube.com/watch?v=DELS-d24QU0)
