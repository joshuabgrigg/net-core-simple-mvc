using Microsoft.AspNetCore.Mvc;

public class HomeController:Controller {
    public string Index() {
        return "hello world";
    }
}