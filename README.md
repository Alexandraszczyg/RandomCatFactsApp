# RandomCatFactsApp

The app connects via API service to external API server, sources random cat fact in JSON format and deserializes it into Random Fact object.
Then the Random Fact object is saved as a TXT file in desired format. If the request is repeated by the client the data is saved in the same .txt file in the line below the previously sourced data.