setlocal EnableDelayedExpansion
set "batchisin=%~dp0"
rem echo %batchisin%

rem Prüfung ob Skype Soundtest den Testsound erkennt und wieder gibt
rem senden Testsound + Empfangen Soundwiedergabe + Ermitteln des Wiedergabesprktrums in Datei

rem 1. Warten auf Wiedergabe
timeout 10

rem 2. Sound senden
"C:\Program Files (x86)\sox-14-4-2\sox"  %batchisin%\grueziwohl.wav -t waveaudio "Lautsprecher"

rem 3. Warten auf Wiedergabe
timeout 3


rem 4. Wiedergabe einlesen
set  recordFile=c:\temp\skypeSoundtest.wav
%batchisin%\..\lib\fmedia\fmedia.exe --record --until=14 --overwrite --out=%recordFile%

rem 5. Wiedergabe auswerten in Ergebnisdatei
set  statistikFile=c:\temp\skypeSoundtest.stat
set fmin=2500
set fmax=2800
"C:\Program Files (x86)\sox-14-4-2\sox" --dft-min 8 %recordFile% -n stat 2>%statistikFile%

rem 6. Prüfung des Frequenzspektrums
set n=1
echo off
for /F "eol=; tokens=2,3* delims= " %%i in ( %statistikFile% ) do (  set /a "n+=1"  && if !n! equ 15  ( if %%j  lss %fmax% if %fmin% lss %%j (echo OK && exit /B 0) ))
echo FEHLER
exit /B 1