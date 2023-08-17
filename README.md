# Drawing Gestures

Drawing Gestures is a Unity template that provides on-screen drawing functionality and handles the drawn gestures.

## Used technologies:
<ul>
<li>New Input System,</li>
<li>Zenject</li>
</ul>

## Platforms:
<ul>
<li>PC,</li>
<li>Mobile.</li>
</ul>

## Main files in project
<table align="center">
  <tr>
    <th>File</th>
    <th>Description</th>
  </tr>
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Drawing/GestureDrawer.cs">GestureDrawer</a></td>
    <td>Methods attached to events in the New Input System - detecting the start and end of gesture drawing</td>
  </tr>
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Drawing/LineManager.cs">LineManager</a></td>
    <td>Handling drawing and fading of the drawn line</td>
  </tr>
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Actions/IGestureAction.cs">IGestureAction</a></td>
    <td>Contract for actions that can be triggered by recognized gestures</td>
  </tr>
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Actions/IGestureData.cs">IGestureData</a></td>
    <td>Contract for data structures that represent the information related to a specific gesture</td>
  </tr>
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Actions/Movement/LineGestureData.cs">LineGestureData</a></td>
    <td>Data structures that represent the information related to a line gesture</td>
  </tr> 
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Actions/Movement/HorizontalLineGestureAction.cs">HorizontalLineGestureAction</a></td>
    <td>Detecting and handling a horizontal line</td>
  </tr>  
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Actions/Movement/VerticalLineGestureAction.cs">VerticalLineGestureAction</a></td>
    <td>Detecting and handling a vertical line</td>
  </tr>  
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Recognition/GestureRecognition.cs">GestureRecognition</a></td>
    <td>Recognizing the drawn gesture</td>
  </tr>  
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Actions/GestureEntityActionHandler.cs">GestureEntityActionHandler</a></td>
    <td>Gesture handling</td>
  </tr>
  <tr>
    <td><a href="https://github.com/UrbanskiJuliusz/DrawingGestures/blob/master/Gesture/Installers/GestureActionsInstaller.cs">GestureActionsInstaller</a></td>
    <td>Ability to inject all available gestures that can be handled</td>
  </tr>  
</table>

## Preview:


https://github.com/UrbanskiJuliusz/DrawingGestures/assets/52629898/51a8c2db-0753-4634-a2b7-715c0731aca2



