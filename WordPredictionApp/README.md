# Word Prediction App

This project is a simple web application that implements a word prediction functionality with results from a custom dictionary and a word prediction web service. The app allows users to enter text in a textarea and displays two lists of word prediction results based on the input text.

## Technologies Used
- HTML
- CSS
- JavaScript
- C#
- SQLite
- Git

## Back-end Tasks

1. Wrote a client for the word predictions web service.
2. Created a service for fetching words from the custom dictionary.
3. Created a web API for the front-end.


## API Functionality
The API performs the following tasks:

- Listens for HTTP requests from the front-end.
- Fetches word predictions from the word predictions web service based on input from the front-end (using the client from task #1).
- Fetches custom dictionary words based on input from the front-end (using the service from task #2).
- Sends the two lists of words as a JSON result in the HTTP response.


## Front-end Tasks
1. Created HTML/CSS for displaying a textarea and two lists of word prediction results.
2. Wrote a JavaScript function that performs a web request to fetch word predictions from the back-end API.
3. On every keypress event in the textarea, the app fetches word predictions based on the text value and displays the results in the two lists.


## Miscellaneous Tasks
1. Generated a token for use with the word predictions web service at https://services.lingapps.dk/misc/CSharpJSRocks.
2. Added the code in a Git project on GitHub and submitted the link at https://services.lingapps.dk/misc/CSharpJSRocks.
Custom Dictionary Description
The custom dictionary is implemented as an SQLite 3 database (Dictionary.db) with a Wordstable containing the columns Id and Value. The database is not encrypted and does not require a password.

## Word Predictions Web Service Description
### URL:
https://services.lingapps.dk/misc/getPredictions

### Authorization: 
`Header: Authorization: Bearer [TOKEN]` (token generated in Miscellaneous task #1)

### Parameters:
- `locale`: String, the language in which the predictions should be computed. Valid values are `da-DK` and `en-GB`.
- `text`: String, the text from which to compute the predictions.

### Response: 
JSON encoded array of strings ordered by prediction probability (descending), for example: `["cars", "cats", "cake"]` 

### Note
This project was created as part of the Wizkids C# test and is a simple test project. However, it should be treated as a project that could run in production in a business environment.



