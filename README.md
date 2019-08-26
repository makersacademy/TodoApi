# TodoApi
TodoApi is a web service created in .NET Core 2.1, PostgreSQL 10 &amp; Visual Studio Code on macOS

### Set up

1. Get the [Mac C# SDK](https://www.microsoft.com/net/download)
    (verify this by executing dotnet on your terminal - you should see output text)
2. Get [Visual Studio](https://visualstudio.microsoft.com/)
3. Clone this repo with: 
    ``` $ git clone git@github.com:lindseydew/TodoApi.git ```
4. Open folder TodoApi in your Visual Studio editor, and double click on `TodoApi.csproj`
5. Install postgres (if you haven't got it already) with 
    ``` $brew install postgresql ``` and start with
    ``` $brew services start postgresql ```
6. Run the sql migration scripts with:
    dotnet ef database update    
7. Run your server with: 
   dotnet watch run
    (verify this by hitting https://localhost:5001/api/todo)


