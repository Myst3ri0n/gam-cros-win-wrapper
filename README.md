# gam-cros-win-wrapper
## A simple Chromebook management app.

This simple Chromebook management app makes it easy to perform simple Chrome OS Google Admin Console tasks. It's a native app for windows written in C#.

- [Install](#installation)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Bug reporting](#bug-reporting)
- [Contributing](#contributing)

![main window screenshot](images/main-screen.png)

## Installation

#### This app **requires** GAM, from [here](https://github.com/jay0lee/gam).

Before running, make sure that you can run `gam print cros` and from that command you get a bunch of 36 character ids, like this: `90a79523-658p-686y-bf20-19638646153c`. `gam` must be in your PATH.

### Beta build (stable, updates less often)
Installation of **beta** is simple. Just pop on over to the [**beta** releases page](https://github.com/iamtheyammer/gam-cros-win-wrapper/releases/latest), and download the msi. It should run on both x86 and x64 platforms.

### Alpha build (less stable, updates very often, has newest features first)
If you'd like the latest **alpha** build (not verified stable, but *should* work), download the Installer.msi file from [ChromebookGUI/Installer/Tool+Installer/Installer.msi (or click here!)](https://github.com/iamtheyammer/gam-cros-win-wrapper/raw/master/ChromebookGUI/Installer/Tool+Installer/Installer.msi)

### Auto-updates
Once installed, the app will let you know when there is an update available. If you download an alpha build, you'll get notifications when a new alpha release is available, and if you download a beta build, you'll only get notifications when new beta builds are available.

### Uninstalling

This app can be uninstalled from your system by going:
- Windows 10 Version >1704 **only**: Settings (Win+I) -> apps -> ChromebookGUI -> Uninstall.
- Every other windows (works on 10 too): Either go run (Win+R) and type in "appwiz.cpl" or go to Control Panel -> Programs and Features. Then, look for ChromebookGUI and press Uninstall.

## Usage

Using the app is fairly simple, and usability is something I want to work on more.

**The first step is to put a serial number/device ID/email/asset ID into the big box asking for it, then pressing submit.** In the output box, you should see the device ID you're working with.

Now, you can click on any of the buttons.

| Item Title      | Equivalent GAM command | Description |
| :------------- | :---------------------- | :---------- |
| Get info       | `gam info cros $deviceId` | Gets about all there is to know about the device. |
| Set Location | `gam update cros $deviceId location $location` | Sets the device's location |
| Set Asset ID | `gam update cros $deviceId assetid $assetId` | Sets the device's Asset ID |
| Set User | `gam update cros $deviceId user $user` | Set's the device's assigned user |
| Disable | `gam update cros $deviceId action disable` | Disables the device, allowing no one to sign into it. |
| Reenable | `gam update cros $deviceId action reenable` | Reenables a disabled device. |
| Change OU | `gam update cros $deviceId ou $ou` | Changes the OU of a device. |
| Deprovision | `gam update cros $deviceId $deprovisionReason acknowledge_device_touch_requirement` | Allows you to deprovision a device. |
| Edit Note | `gam update cros $deviceId note $note` | Allows you to update the note on a device. |
| Copy ID | not a single gam command. to find a device id by serial number: `gam print cros query "id:$serialNumber"`, or by user: `gam print cros query "user:$user"` | Takes the current device ID and copies it to the clipboard. |

Output will be displayed in the large box on the bottom of the window. Use the `Copy output to clipboard` button to place the entire output box in the clipboard.

## Screenshots
These screenshots hail from the current [**beta**](https://github.com/iamtheyammer/gam-cros-win-wrapper/releases/latest) release.

| Description | Image     |
| :------------- | :------------- |
| Main window, displayed after startup.   | ![main window](images/main-screen.png)       |
| Main window, maximized (makes output window larger) | ![main window maximized](images/main-screen-maximized.png)
| Device selection screen. Shown if you enter an email with more than once device. | ![device-selection small](images/device-selection-small.png) |
| Asset ID change window | ![assetid change](images/assetId.png) |
| Set User window | ![user change](images/userChange.png) |
| Change OU window | ![change ou small](images/org-selection-small.png) |
| Deprovision window | ![deprovision window](images/deprovisionSelect.png) |
| Set/change note window | ![set/change note window](images/note.png) |

<details>
<summary>Both the device selection and OU selection screens expand. Click for an expanded image.</summary>
<br>
  <p>Expanded Device Selection</p>
  <img src="images/device-selection-large.png">
  <p>Expanded Organizational Unit Selection</p>
  <img src="images/org-selection-large.png">
</details>


## Bug reporting
Please open an issue! I want to fix your bugs, I just don't know about them yet. Please include a screenshot with your report.

## In the future (To-Do)
- Add a menu bar with some simple settings
- Come up with a name -- I'm using ChromebookGUI right now. (please help me with this!)

## Contributions
Always welcome! Submit a pull request!

I bet that [these](https://github.com/iamtheyammer/gam-cros-win-wrapper/tree/master/docs) docs will help you write for this as I've made many more than one class and plenty of methods.

Thanks for your help!

### A little more information about my versioning and updating system
When a new version is pushed out, three things must be at least checked.  
- Software.cs:
  - Software.Type
  - Software.Version
- Installer:
  - Properties -> Version (**must** match Software.Version)
- docs/releases.json:
  - Change the JSON to match your Software.Version (again, **must** match)
When these things are changed,
1. Old versions of software are prompted to upgrade (caused by changing Software.Version and docs/releases.json)
2. Installer allows users of previous versions to upgrade. Otherwise it will refuse to install. (caused by Installer)

What does changing Software.Type do? Well, it changes what track the software is on. Beta releases have `Software.Type = "beta"` and alpha releases have `Software.Type = "beta"`. This way, if there is a new alpha release, beta users will not be notified and vise versa.
## License
MIT License.