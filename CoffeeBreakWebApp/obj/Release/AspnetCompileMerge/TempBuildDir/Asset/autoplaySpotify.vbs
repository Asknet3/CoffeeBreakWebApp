Set WshShell = WScript.CreateObject("WScript.Shell")
Comandline = "C:\Users\asknet\AppData\Roaming\Spotify\Spotify.exe"
WScript.sleep 500
CreateObject("WScript.Shell").Run("spotify:user:1169593196:playlist:40X6g47YZLkPSbWY6nuIDz")
WScript.sleep 3000
WshShell.SendKeys " "