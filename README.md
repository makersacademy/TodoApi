# TodoApi
TodoApi is a web service created in .NET Core 2.1, PostgreSQL 10 &amp; Visual Studio Code on macOS

### Set up

1. Get the [Mac C# SDK version 2.1](https://dotnet.microsoft.com/download/dotnet-core/2.1) installer
    (verify this by executing `$ dotnet` on your terminal - you should see output text)
2. Get [Visual Studio](https://visualstudio.microsoft.com/)
3. Clone this repo with: 
    `$ git clone git@github.com:makersacademy/TodoApi.git`
4. Open folder TodoApi in your Visual Studio editor, and double click on `TodoApi.csproj`
5. Install postgres (if you haven't got it already) with 
    `$ brew install postgresql` and start with
    `$ brew services start postgresql`
6. Run the sql migration scripts with:
    `$ dotnet ef database update`    
7. Run your server with: 
   `$ dotnet watch run`
    (verify this by hitting https://localhost:5001/api/todo)
    
### Skills Checklist

- [ ] I can understand how data is sent from the browser and returned from the server
- [ ] I can render a c sharp template view
- [ ] I can post new items from a template and persist this to a database
- [ ] I can add new fields to the model and database

#### Resources

##### Videos + Github examples
In the `makers-video` please look at:

- navigating-a-csharp.mov
- add-template-csharp.mov (branch add-template-to-view)
- creating-new-todo-items.mov (branch add-items-to-db)
- adding-a-migration.mov (branch add-fields-to-model)

https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code







