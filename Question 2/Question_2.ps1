# If you don't have access to powershell on your machine, please do not hesitate to fetch the docker image to do this exercice.
# The code below is an example on how to fetch the json from the endpoint.
# Please provide the proper code to have a display that matches the question.
$response1 = Invoke-WebRequest -URI http://jsonplaceholder.typicode.com/albums
$response2 = Invoke-WebRequest -URI http://jsonplaceholder.typicode.com/photos
