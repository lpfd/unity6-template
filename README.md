# Leap Forward Unity 6 Project Template

## Creating a Repository Using a GitHub Template

Sign in to GitHub: First, log in to your GitHub account.

![github-sing-in](Documentation/Images/github-sing-in.png)

Navigate to the Repository Template. Click "Use this template": On the template repository's main page, you will see a green button labeled "Use this template." Click on it.

![github-use-this-template](Documentation/Images/github-use-this-template.png)

Create a New Repository from the Template:

- **Owner**: Choose the owner of the repository (you or an organization you belong to).

- **Repository Name**: Enter a name for your new repository.

- **Description (optional)**: Add a description if you like.

- **Repository Settings**: Choose whether the repository should be public or private.

- **Create Repository**: Click the green button labeled "Create repository from template." Your new repository will be created based on the template.

![github-create-repository](Documentation/Images/github-create-repository.png)

## Cloning the Repository Locally Using GitHub Desktop

Launch the GitHub Desktop client on your computer. If you're not already signed in, click "Sign in to GitHub.com" and enter your credentials.

Click on the "File" menu in the top left corner. Select "Clone repository..." from the dropdown.

![github-desktop-create-repository](Documentation/Images/github-desktop-create-repository.png)

Choose the Repository to Clone:

URL or GitHub.com: If your repository is hosted on GitHub.com, select "GitHub.com.". Choose the repository you created from the list. If you don't see it, use the search bar to find it.

Click "Choose..." to select where on your computer you want to clone the repository.

Click the blue "Clone" button. GitHub Desktop will clone the repository to the selected location on your computer.

![github-desktop-clone](Documentation/Images/github-desktop-clone.png)

## Setting up git LFS

Open command prompt for the cloned repository.

![github-desktop-command-prompt](Documentation/Images/github-desktop-command-prompt.png)

Initialize Git LFS:

```bash
git lfs install
```

Create or update the ```.gitattributes``` file in your project's root directory with the following content: https://gist.github.com/Srfigie/77b5c15bc5eb61733a74d34d10b3ed87


This configuration ensures that:

- Text-based files like scripts (*.cs) and shaders (*.shader) are handled as text.
- Unity YAML files (*.mat, *.anim, *.unity, etc.) are set up for proper merging.
- Binary assets such as images, audio, and 3D models are tracked by Git LFS.

Inform Git LFS to track the specified file types:

```bash
git lfs track "*.jpg" "*.jpeg" "*.png" "*.gif" "*.psd" "*.ai" "*.tif" "*.mp3" "*.wav" "*.ogg" "*.mp4" "*.mov" "*.FBX" "*.fbx" "*.blend" "*.obj" "*.a" "*.exr" "*.tga" "*.pdf" "*.zip" "*.dll" "*.unitypackage" "*.aif" "*.ttf" "*.rns" "*.reason" "*.lxo"
```

Stage the .gitattributes file and any other changes, then commit them:

![github-desktop-commit-lfs](Documentation/Images/github-desktop-commit-lfs.png)

![github-desktop-push](Documentation/Images/github-desktop-push.png)

