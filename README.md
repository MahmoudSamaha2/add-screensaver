# ScreensaverPlayer

A simple Windows screensaver (.scr) that plays an MP4 video in fullscreen using Windows Media Player.

## Instructions

### 1. Build 

1. **Download the screensaver**
   - Go to the `Actions` tab in your GitHub repository.
   - Select the latest workflow run.
   - Download the `ScreensaverPlayer` artifact. It will contain:
     - `ScreensaverPlayer.scr` (the screensaver file)
     - `video.mp4` (your video)

2. **Install the screensaver**
   - Copy both files to your Windows PC.
   - Move/copy the `.scr` file (and your `video.mp4`) to `C:\Windows\System32` or right-click the `.scr` file and select `Install`.

### 2. Usage
- The screensaver will play your video in a loop.
- Press any key or move the mouse to exit.

### 3. Customization
- To use a different video, change the `videoPath` in `MainForm.cs` or replace `video.mp4` before pushing to GitHub.

---

**Note:**
- This screensaver only works on Windows.
- You must have Windows Media Player installed.
- For advanced features (multi-monitor, settings, etc.), further code changes are needed.
