cd %~dp0
start C:\"Program Files"\ConEmu\ConEmu64.exe -cmdlist cmd.exe /k "npm run dev:next" -cur_console:fn:t:"Next dev" ^|^|^| cmd.exe /k "npm run dev:next:tsc" -cur_console:s1TVn:t:"tsc --watch" ^|^|^| cmd.exe /k "npm run dev:next:syncfiles" -cur_console:s1THn:t:"Storybook" ^|^|^| cmd.exe /k "npm run dev:storybook" -cur_console:s2THn
start http://localhost:3000
start http://localhost:9001
