# UnfocusTest
# For App theme binding
Open styles.xaml in resources

Uncomment the <!-- Works -->, comment <!-- Doesnt work--> and build to see it changing the selected menuitem to red.
the part below <!-- Doesnt work --> well.. doesnt work.

# For onresume
## Variant one,
Build app as is in the repo, deploy on android. 
Wait for it to launch, click on SetMainPage in the menu.
Bring app to background and back to foreground. Crash happens.
What this does it changes the mainpage to a navigationpage while the app is in the foreground and then tries to switch it back to a shell in the onresume.

## Variant two,
Comment out MainPage = new AppShell(); in onresume, Line 16.

Build app and deploy on android. 

Wait for it to launch, then immediately go to the background and bring app back to foreground. 

It will crash.

What this scenario does : app goes to background with mainpage being a shell. then in onresume we try to make it a navigationpage.

## Variant three,
Comment out Line 16. and line 19.

Uncomment Line 23 untill Line 28 (the entire mainthread thing.) But leave the task.delay commented.
build app and deploy on android. 

Wait for it to launch, then immediately go to the background and bring app back to foreground. 

It will crash.

What this scenario does :  app goes to background with mainpage being a shell. then in onresume we try to make it a navigationpage. but this time we try it on the mainthread.

## Make variant three work. (sometimes)
Comment out Line 16. and line 19.

Uncomment Line 23 untill Line 28 (the entire mainthread thing.) but leave the task.delay commented.

build app and deploy on android. wait for it to launch, then immediately go to the background and bring app back to foreground. 

It will crash on slower devices.

What this scenario does : app goes to background with mainpage being a shell. 

Then in onresume we try to make it a navigationpage. but this time we try it on the mainthread. and we add a small delay before we do the swap.
