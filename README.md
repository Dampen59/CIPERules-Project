# CIPERules-Project - EPIC RPG Automation Project

CIPERules-Project is an inactive open-sourced project that manages to automates actions for the Discord game "EPIC RPG"

## Using the project

Clone the project and open the solution in Visual Studio. Nu-Get packages will automatically fetch if needed.

You will also need an API KEY for the bypass system to work

## What is done

- CIPERules-Discord - Detects EPIC RPG captcha requests and send them to bypass, then returns the captcha solution to CIPERules-Client

- CIPERules-Client - Hooking to Discord via it's Handle, fetches captcha solutions and automatically send them to respect EPIC RPG Guard request

## Contributing
Any contributions are welcome.