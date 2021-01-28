<html>
<head>
<style>
    
    .codeHeader {
    box-sizing: content-box;
    background-color: hsla(0,0%,95%,1);
    background-color: var(--theme-body-background-dark);
    color: hsla(0,0%,9%,1);
    color: var(--theme-text);
    display: flex;
    flex-direction: row;
    font-size: .8rem;
    border: 1px solid hsla(0,0%,89%,1);
    border: 1px solid var(--theme-border);
    border-bottom: 0;
    margin-top: 16px;
    min-height: 30px;
    }

    .codeHeader>.language {
    padding: 2px 16px;
    flex-grow: 1;
    }

    pre {
    font-size: .875rem;
    overflow: auto;
    border: 1px solid hsla(0,0%,89%,1);
    border: 1px solid var(--theme-border);
    background-color: hsla(0,0%,98%,1);
    background-color: var(--theme-body-background-medium);
    font-smooth: auto;
    padding: 1rem;
    margin: 1rem 0 0;
    white-space: pre;
    word-spacing: normal;
    word-break: normal;
    word-wrap: normal;
    -moz-tab-size: 4;
    -o-tab-size: 4;
    tab-size: 4;
    -webkit-hyphens: none;
    -ms-hyphens: none;
    hyphens: none;
    -webkit-overflow-scrolling: touch;
    }
</style>
</head>
<body>

<h2>Agenda</h2>

<h4>Installation:</h4> 

<p>.NET Core-CLI: dotnet tool install -g Microsoft.dotnet-httprepl</p>


<h4>Starten von HttpRepl</h4>
<p>Nach der erfolgreichen Installation des Tools können Sie folgenden Befehl ausführen, um HttpRepl zu starten: httprepl</p>

<h4>Übersicht über alle Http-Repl Befehle</h4>
<p>>httprepl -h oder httprepl -help </p>


<p>------------------ Ausgabe -------------------- </p>

Usage:
  httprepl [<BASE_ADDRESS>] [options]

Arguments:
  <BASE_ADDRESS> - The initial base address for the REPL.

Options:
  -h|--help - Show help information.

Once the REPL starts, these commands are valid:

Setup Commands:
Use these commands to configure the tool for your API server

connect        Configures the directory structure and base address of the api server
set header     Sets or clears a header for all requests. e.g. `set header content-type application/json`

HTTP Commands:
Use these commands to execute requests against your application.

GET            get - Issues a GET request
POST           post - Issues a POST request
PUT            put - Issues a PUT request
DELETE         delete - Issues a DELETE request
PATCH          patch - Issues a PATCH request
HEAD           head - Issues a HEAD request
OPTIONS        options - Issues a OPTIONS request

Navigation Commands:
The REPL allows you to navigate your URL space and focus on specific APIs that you are working on.

ls             Show all endpoints for the current path
cd             Append the given directory to the currently selected path, or move up a path when using `cd ..`

Shell Commands:
Use these commands to interact with the REPL shell.

clear          Removes all text from the shell
echo [on/off]  Turns request echoing on or off, show the request that was made when using request commands
exit           Exit the shell

REPL Customization Commands:
Use these commands to customize the REPL behavior.

pref [get/set] Allows viewing or changing preferences, e.g. 'pref set editor.command.default 'C:\\Program Files\\Microsoft VS Code\\Code.exe'`
run            Runs the script at the given path. A script is a set of commands that can be typed with one command per line
ui             Displays the Swagger UI page, if available, in the default browser

Use `help <COMMAND>` for more detail on an individual command. e.g. `help get`.
For detailed tool info, see https://aka.ms/http-repl-doc.



<h4>Herstellen einer Verbindung mit der Web-API</h4>

<p>Stellen Sie mithilfe des folgenden Befehls eine Verbindung mit einer Web-API her:</p>
<p>httprepl <ROOT URI></p>

<p><ROOT URI> ist der Basis-URI für die Web-API.</p>
<p>httprepl https://localhost:5001</p>

<p>Alternativ können Sie den folgenden Befehl jederzeit ausführen, während HttpRepl ausgeführt wird:</p>
<p>connect <ROOT URI></p> 
<p>(Disconnected)> connect https://localhost:5001</p>






</body>
</html>











