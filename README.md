# _Pierre's Bakery_

#### _CLI Order Intake Program using TDD_

#### By _**Carlos Mendez**_

## Technologies Used

* C#
* .NET 5
* MS Test

## Description

_This project demonstrates TDD and C# environment setup practices. The app welcomes the user and informs them of the single-item price of the baked goods being offered for sale. It allows the user to input their desired number of loaves of bread and pastries. It returns the discounted price. Bread is Buy 2, get 1 free with a single loaf selling for $5 and Pastries are Buy 1 for $2 or 2 for $3._


## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A command line interface like Terminal or GitBash to run and interact with the console app.

### Installation
1. Clone the repository: `$ git clone https://github.com/yesthecarlos/Bakery.Solution`
2. Navigate to the `Bakery.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base
4. To run the console app:
    * Navigate to `Bakery.Solution/Bake` in your command line
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
    * Finally, run the command `dotnet run` to run the project!
    * Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
5. To run tests:
    * Navigate to `Bakery.Solution/Bake.Tests` in your command line.
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Finally, run the command `dotnet test` to run the tests!

## Specs
 
### BreadTests
```c#
  public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("1");
      
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  public void StraightBreadPrice_ReturnsUndiscountedBreadPrice_Int()
    {
      string breadCount = "3";
      int breadPrice = 15;
      Bread newBread = new Bread(breadCount);

      int result = newBread.StraightBreadPrice(breadCount);
      
      Assert.AreEqual(breadPrice, result);
    }
  public void GetBreadPrice_ReturnsDiscountedBreadPrice_Int()
    {
      int breadPrice = 40;
      string breadCount = "12";
      Bread newBread = new Bread(breadCount);

      int result = newBread.GetBreadPrice(breadCount);
    
      Assert.AreEqual(breadPrice, result);
    }
```
### PastryTests
```c#   
  public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("1");

      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

  public void StraightPastryPrice_ReturnsUndiscountedPastryPrice_Int()
    {
      string pastryCount = "3";
      int pastryPrice = 6;
      Pastry newPastry = new Pastry(pastryCount);

      int result = newPastry.StraightPastryPrice(pastryCount);
      
      Assert.AreEqual(pastryPrice, result);
    }

  public void GetPastryPrice_ReturnsDiscountedPastryPrice_Int()
    {
      string pastryCount = "4";
      int pastryPrice = 7;
      Pastry newPastry = new Pastry(pastryCount);
      
      int result = newPastry.GetPastryPrice(pastryCount);
      
      Assert.AreEqual(pastryPrice, result);
    }
```
## Feature Plans

* _Fully implementing static variables will let the user keeping adding onto an order._

## License

_Copyright 2021 Carlos Mendez_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_

## Contact Information

_carlosmendez86@gmail.com_