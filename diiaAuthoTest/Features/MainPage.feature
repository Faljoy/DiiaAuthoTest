Feature: MainPage
	As a user 
	I want to serch field on main page 
	In order to quickly find needed information 

Background:
	Given main page is open

@validSerchCheck @valid
Scenario: Check the search results whith valid input in search field
	When i input 'відкрити ФОП' in search field
	When i click on seach button
	Then i see a validSearchResult page with text 'За вашим запитом знайдено матеріалів:'

@inValidTextInSerchCheck @invalid
Scenario: check with no results search with invalid input in search field
	When i input 'dsdhfu343@9_#$@id' in search field
	When i click on seach button
	Then i see a invalidSearchResult page with text 'За вашим запитом не знайдено матеріалів'

#Feature: RegistrationPage
#As a user
#I want a button registration
#In order to i can went to page registration on service
@OpenRegistration
Scenario: check opened registration page on header menu
	When i click on registration buttom
	Then i see on a opened registration page text 'Будь ласка, авторизуйтесь'

#Feature: FAQ page
#As a user
#I want a button know more
#In order to i can went to page faq where i can see needed me information
@OpenRegistration
Scenario: check opened faq page on main page
	When i click on know more buttom
	Then i see on a opened faq page text 'Що таке електронний підпис?'

#Feature: Child Planing page
#As a user
#I want a button planing child
#In order to i can know about healthy food
@OpenRegistration
Scenario: check opened healthy food page
	When i click on i planing child buttom
	When i click on i healthy food buttom
	Then i see on a opened food text 'Здоровий спосіб життя'
#	@OpenDataPage
# Scenario: check opened data page on header menuetest
#	When i click on diia page open data
#	Then i see on a opened data page text 'Дія.Відкриті дані'