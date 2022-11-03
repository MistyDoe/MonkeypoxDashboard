using DashBoardAPI.Models;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace DashBoardAPI.Services
{
    public class Forcast
    {
        public List<int> CasesForCnty (List<Case> cases)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptSource source = engine.CreateScriptSourceFromFile("arima.py");
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("data", cases);
            throw new NotImplementedException();
        }
    }
}
