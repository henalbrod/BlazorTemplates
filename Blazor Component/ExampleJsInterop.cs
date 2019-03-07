using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class ExampleJsInterop
    {

        IJSRuntime _jSRuntime;

        public ExampleJsInterop(IJSRuntime jSRuntime) {
            _jSRuntime = jSRuntime;
        }

        public async Task<string> Prompt(string message)
        {
            // Implemented in exampleJsInterop.js
            return await _jSRuntime.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }
    }
}
