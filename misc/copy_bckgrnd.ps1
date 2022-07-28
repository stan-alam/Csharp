cd C:\users\********\appdata\local\packages\Microsoft.Windows.ContentDeliveryManager_**********\LocalState\Assets\
Get-ChildItem | Where-Object { $_.LastWriteTime -ge "07/20/2022" } | Copy-Item -Destination C:\images\
call runMe.bat
