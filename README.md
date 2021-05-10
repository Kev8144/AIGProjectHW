
# Answer in Genesis Homework Project
A simple README document to get started.

# Getting Started
Tools to get strarted:
1.  Latest Visual Studio 2019 IDE
2.  Long term support version of .NET Core (3.x)
3.  Azure account
4.  Git

# Git workflow / Trunk based method
Use these steps/commands for your workflow for checking out code, working on new features, commiting, and pushing those new features:

1. *Create a local repo on your workstation:*
```
   git clone <url-to-repo>
```
2. *Create a new feature branch on your local machine from master or create a user branch:*
```
   git checkout -b features/<feature-name>
                        or
   git checkout -b users/<firstNameLastInitial>/<featureName>

```
3. *When ready to commit:*
```
   git add .
   git commit -m "<description-of-changes>"
```
4. *When ready to push branch to server get latest from master:*
```
   git pull origin master
   git merge <your-branch-name>
```
* While on your feature branch 

5. *Push commits of your feature branch to the server:*
```
   git push origin <your-branch-name>
```
  
6. *When a feature is ready, you can create a pull request for your feature branch to master from Azure DevOps*

<br />
<br />
---

# Build and Test
-  To build the project, in the root directory:
```bash
$ dotnet build
```
-  To test the project, in the root directory:
```bash
$ dotnet test
```
# Other Information
After cloning the project locally, feel free to make your own branch following the naming construct:
```bash
users/<firstNameLastInitial>/<featureName>
```
- Pushing (syncing) your personal users branch is fine
- Feel free to make a Pull Request for a code review before trying to merge your branch into master
- Copy PR link and send it to reviewers for a code review.
- Feel free to use Visual Studio rather than the command line if that works best for you