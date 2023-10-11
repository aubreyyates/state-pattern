using StatePattern;
using StatePattern.Tools;

// Create a canvas that a user can draw elements on.
var canvas = new Canvas();

// Select the circle tool.
canvas.SetCurrentTool(new CircleTool());

// Draw with the circle tool.
canvas.MouseDown();
canvas.MouseUp();

// Select the brush tool.
canvas.SetCurrentTool(new BrushTool());

// Draw with the brush tool.
canvas.MouseDown();
canvas.MouseUp();