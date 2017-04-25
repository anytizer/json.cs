# JSON.CS
A C# example interfacing with JSON data.

 - HTTP Get
 - HTTP Post

Example GET

    web w = new web();
    string members_url = (new endpoints()).members;
    string t = w.get(members_url);
