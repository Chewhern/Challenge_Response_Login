# Challenge_Response_Login
C# WinForms that briefly showcases how to use digital signature(ED25519) to act as a passwordless login mechanism

This project will assume you already installed libsodium(Open Source Cryptography Library) and ASodium, otherwise
this wouldn't work, if you have installed libsodium and don't want to make sure that the libsodium is in the
correct nuget folder in your windows OS, then simply put in the correct libsodium dll(determine by your system
architecture is it x64 or is it x86). You can find the correct libsodium dll under packages in the application folder.

To make it work either you make sure the libsodium dll(determine by your system or cpu architecture)
is in the application folder or in the correct default nuget folder.

The application can be run smoothly otherwise, you will be finding yourself debugging and wondering what's wrong.
