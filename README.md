## Smart Enum model binding for dotnet MVC or Razor page forms

### How to use
* Create the Model Binder Class from [here](./SmartEnum.ModelBinding/SmartEnumModelBinder.cs)
* Create the Model Binder Provider from [here](./SmartEnum.ModelBinding/SmartEnumBinderProvider.cs)
* Add the following in ```ConfigureServices``` Method of ```StartUp.cs``` of the Web Application project
```csharp
    services.AddRazorPages()
        .AddMvcOptions(options =>
        {
            options.ModelBinderProviders.Insert(0, new SmartEnumBinderProvider());
        });
```
* Use the Enum options explicitly in the Razor page. Example can be seen [here](./WebAppExample/Pages/Users/Create.cshtml)
```cshtml
<div class="form-group">
    <label asp-for="Usr.Gender" class="control-label"></label>
    <select asp-for="Usr.Gender" class="form-control">
        @foreach (var item in GenderEnum.List)
        {
            <option value="@item.Name" selected="@(item.Name == Model.Usr.Gender.Name)">@item.Name</option>
        }
    </select>
    <span asp-validation-for="Usr.Gender" class="text-danger"></span>
</div>
```