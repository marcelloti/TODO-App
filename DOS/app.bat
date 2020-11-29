@echo off

:reset
endlocal

REM -------------------------------------------
REM App config
setlocal enabledelayedexpansion

REM White background color
color 70

REM -------------------------------------------
REM Global Variables

REM Task List Object
set taskList[0]='[Empty task list]'

REM Current Index of task list
set /a currentIndex=-1

REM ----------------------------
REM TEMPORARY
REM set taskList[0]='Task A'
REM set taskList[1]='Task B'
REM set taskList[2]='Task C'
REM set /a currentIndex=2
REM TEMPORARY
REM ----------------------------

REM -------------------------------------------
REM   START CODE MARKER
REM -------------------------------------------
:start
REM cls

REM -------------------------------------------
REM Global Functions

REM ASCII BANNER
:banner
echo.
echo """"""""""""""""""""""""""""""""""""""""""""
echo " _____         _         _                "
echo "|_   _|__   __| | ___   / \   _ __  _ __  "
echo "  | |/ _ \ / _` |/ _ \ / _ \ | '_ \| '_ \ "
echo "  | | (_) | (_| | (_) / ___ \| |_) | |_) |"
echo "  |_|\___/ \__,_|\___/_/   \_\ .__/| .__/ "
echo "                             |_|   |_|    "
echo "                                          "
echo """"""""""""""""""""""""""""""""""""""""""""
echo.
goto:menu

REM ******************************
REM        MENU
REM ******************************
:menu
echo            ACTIONS
echo  ==================================
echo * 1. List tasks                    * 
echo * 2. Add task                      *
echo * 3. Remove task                   *
echo * 4. Clear task list               *
echo * 5. Exit                          * 
echo  ==================================

set /p option= Choose an option: 
echo ------------------------------
if %option% equ 1 goto option1
if %option% equ 2 goto option2
if %option% equ 3 goto option3
if %option% equ 4 goto option4
if %option% equ 5 goto option5
if %option% GEQ 6 goto option6
EXIT /B 0

REM ******************************
REM        OPTION 1
REM ******************************
:option1
cls
echo ==================================
echo *      Task List                 *
echo ==================================
echo.

REM %%T = TaskName
for /F "tokens=2 delims==" %%T in ('set taskList[') do (
    if NOT %%T == "" (
      echo %%T
    )
)

echo.
pause
goto start


REM ******************************
REM        OPTION 2
REM ******************************
:option2
cls
echo ==================================
echo *      Add Task                  *
echo ==================================
set /P taskname=Enter the task name: 
echo.
set /A currentIndex = currentIndex + 1
set taskList[!currentIndex!]=%taskname%

echo        Task registered!
echo.        
pause
goto start


REM ******************************
REM        OPTION 3
REM ******************************
:option3
cls
echo ==================================
echo *     Remove Task                *
echo ==================================

REM Listing all items
set /a counter = 0
for /F "tokens=2 delims==" %%T in ('set taskList[') do (
    echo [!counter!] %%T
    set /a counter = counter + 1
)
echo.
set /P taskid=Enter the task number to be removed:
echo.

REM Check as a number
set /a varCheck=%taskid%
if NOT %varCheck% == %taskid% (
    echo.
    echo ERROR: Unknown task ID!
    echo.
    pause
    goto start
)

REM Creating a new list
set newList[0]='[Empty task list]'
set /a counterLoop = 0
set /a index = 0

for /F "tokens=2 delims==" %%T in ('set taskList[') do (
    if NOT !counterLoop! == !taskid! (
       set newList[!index!]=%%T
       set /a index = index + 1
    )
    set /a counterLoop = !counterLoop! + 1
)

echo        Task removed
echo.
echo        The new list of tasks is:
set /a counter = 0
for /F "tokens=2 delims==" %%T in ('set newList[') do (
    echo [!counter!] %%T
    set /a counter = counter + 1
)
echo.
pause
EXIT /B

REM ******************************
REM        OPTION 4
REM ******************************
:option4
cls
echo ==================================
echo *     Clear task list            *
echo ==================================
set /P reply=Do you really want to delete all tasks ? (y/N)
if %reply% equ y (
  goto clear
) else if %reply% equ Y (
  goto clear
) else if %reply% equ N (
  goto start
) else if %reply% equ n (
  goto start
) else (
  echo.
  echo ERROR: Unknown option!
  echo.
  pause
  goto start
)

:clear
    echo.
    echo        All tasks removed!
    echo.         
    pause
goto reset

REM ******************************
REM        OPTION 5
REM ******************************
:option5
cls
exit

REM ******************************
REM        UNKNOWN OPTION
REM ******************************
:option6
echo.
echo ERROR: Unknown option!
echo.
pause
goto start

REM End of Global Functions
REM -------------------------------------------







