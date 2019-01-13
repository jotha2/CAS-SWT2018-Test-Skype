rem Prüfung ob Skype Soundtest den Testsound erkennt und wieder gibt
rem senden Testsound + Empfangen Soundwiedergabe + Ermitteln des Wiedergabesprktrums in Datei

rem 5. Wiedergabe auswerten in Ergebnisdatei
"C:\Program Files (x86)\sox-14-4-2\sox.exe" --dft-min 8 "c:\temp\skypeSoundTestTA.wav" -n stat 2>"c:\temp\skypeSoundTestTA.stat"
