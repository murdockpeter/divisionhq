@echo off
echo ========================================
echo Checking for API Documentation Files
echo ========================================
echo.

set GAME_DIR=D:\SteamLibrary\steamapps\common\Hex of Steel

if exist "%GAME_DIR%\HexOfSteel_API_Complete.md" (
    echo [FOUND] Full API: %GAME_DIR%\HexOfSteel_API_Complete.md
    echo Opening file...
    start "" "%GAME_DIR%\HexOfSteel_API_Complete.md"
) else (
    echo [NOT FOUND] %GAME_DIR%\HexOfSteel_API_Complete.md
)

echo.

if exist "%GAME_DIR%\HexOfSteel_API_Core.md" (
    echo [FOUND] Core API: %GAME_DIR%\HexOfSteel_API_Core.md
    echo Opening file...
    start "" "%GAME_DIR%\HexOfSteel_API_Core.md"
) else (
    echo [NOT FOUND] %GAME_DIR%\HexOfSteel_API_Core.md
)

echo.

if exist "%GAME_DIR%\HexOfSteel_API_COMPLETE_WITH_PRIVATE.md" (
    echo [FOUND] Complete API with Private Members: %GAME_DIR%\HexOfSteel_API_COMPLETE_WITH_PRIVATE.md
    echo Opening file...
    start "" "%GAME_DIR%\HexOfSteel_API_COMPLETE_WITH_PRIVATE.md"
) else (
    echo [NOT FOUND] %GAME_DIR%\HexOfSteel_API_COMPLETE_WITH_PRIVATE.md
)

echo.

if exist "%GAME_DIR%\HexOfSteel_API_Core_With_Private.md" (
    echo [FOUND] Core API with Private Members: %GAME_DIR%\HexOfSteel_API_Core_With_Private.md
    echo Opening file...
    start "" "%GAME_DIR%\HexOfSteel_API_Core_With_Private.md"
) else (
    echo [NOT FOUND] %GAME_DIR%\HexOfSteel_API_Core_With_Private.md
)

echo.
echo ========================================
echo Checking Player.log for errors...
echo ========================================
echo.

set LOG_FILE=C:\Users\Peter G. Robbins\AppData\LocalLow\War Frogs Studio\Hex of Steel\Player.log

if exist "%LOG_FILE%" (
    echo Last 20 lines of Player.log:
    echo.
    powershell -Command "Get-Content '%LOG_FILE%' -Tail 20"
) else (
    echo [NOT FOUND] Player.log
)

echo.
echo ========================================
pause
