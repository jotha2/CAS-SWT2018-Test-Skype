rem Prüfung ob Skype Soundtest den Testsound erkennt und wieder gibt
rem senden Testsound + Empfangen Soundwiedergabe + Ermitteln des Wiedergabesprktrums in Datei

rem 1. Warten auf Wiedergabe
timeout 10

rem 2. Sound senden
"C:\Program Files\sox-14-4-2\sox"  C:\Workarea\CAS-SWT2018-Test-Skype\GIT\CAS-SWT2018-Test-Skype\Win\TA_Skype\resources\audiocheck.net_sin_1000Hz_-3dBFS_2s.wav -t waveaudio "Lautsprecher"
"C:\Program Files\sox-14-4-2\sox"  C:\Workarea\CAS-SWT2018-Test-Skype\GIT\CAS-SWT2018-Test-Skype\Win\TA_Skype\resources\audiocheck.net_sin_1000Hz_-3dBFS_2s.wav -t waveaudio "Lautsprecher"

rem 3. Warten auf Wiedergabe
timeout 3


rem 4. Wiedergabe einlesen
C:\Workarea\CAS-SWT2018-Test-Skype\resources\fmedia\fmedia.exe --record --until=5 --overwrite --out=\temp\skypeSoundTest.wav

rem 5. Wiedergabe auswerten in Ergebnisdatei
"C:\Program Files\sox-14-4-2\sox" --dft-min 8 c:\temp\skypeSoundtest.wav -n stat 2>\temp\skypeSoundTest.stat
