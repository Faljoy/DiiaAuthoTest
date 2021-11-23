Feature: DataOpenPage
	As a user
	I want to open dataPage
	In order to serch information about opened data

Background:
	Given data page is open

@SearchOnDataPage @find @valid
Scenario: check search in fields a valid requestion
	When i input 'Реєстр' in daat search field
	When i click on seach button on data page
	Then i see a validSearchResult data page with text 'За вашим запитом, знайдено'

@SearchOnDataPage @find @InValid
Scenario: check search in fields a Invalid requestion
	When i input 'sdfsdf' in daat search field
	When i click on seach button on data page
	Then i see a invalidSearchResult data page with text 'За вашим запитом, не знайдено матеріалів'

#Feature: AnalicsPage
#As a user
#I want to open apiAnaliticsPage
#In order to see information about opened api data
@watchApiAnalytics
Scenario: check api analytics in Data open page
	When i click on analytic button
	When i click on api on analitycs page
	Then i see a  page with text 'Використання API порталу'

#Feature: FAQDataPage
#As a user
#I want to open FAQ Page
#In order to see information about opened data
Scenario: check FAQ in Data open page
	When i click on FAQ button
	Then i see a data page with text 'Питання та відповіді'

#Feature: All sets data page
#As a user
#I want to open all set  Page
#In order to see information about all set data open
Scenario: check All Sets in Data open page
	When i click on All sets button
	Then i see a all set page with text 'наборів даних'