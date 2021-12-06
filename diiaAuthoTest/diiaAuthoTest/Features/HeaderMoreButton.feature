Feature: Button more on the header menu
As a user
I want a button-dropdown more
In order to i can went to page with me needed

Background:
	Given main page is open

Scenario Outline: Redirect in more button
	When i click on more button
	When i click <button> on more button
	Then i see title on page <title>

	Examples:
		| button            | title                          |
		| Open Data         | Дія.Відкриті дані              |
		| Bussiness         | Дія.Бізнес - Головна сторінка  |
		| Digital education | Дія. Цифрова Освіта            |
		| Paperless         | Підтримка Paperless            |
		| Data Gov          | Головна сторінка - Data.gov.ua |