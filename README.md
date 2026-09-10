# RandomCatFactsApp

The app connects via API service to external API server, sources random cat fact in JSON format and deserializes it into Random Fact object.
Then the Random Fact object is saved as a TXT file in desired format. If the request is repeated by the client the data is saved in the same .txt file in the line below the previously sourced data.
The data format represents Fact ; Length. 

Please configure the number of requests to be performed  to the external server and file path in Configuration>appsettings.json folder. Detailed instructions can be found inside the  appsettings.json file, in the the comments.