
import 'vtk.js/Sources/favicon';

import vtkActor from 'vtk.js/Sources/Rendering/Core/Actor';
import vtkFullScreenRenderWindow from 'vtk.js/Sources/Rendering/Misc/FullScreenRenderWindow';
import vtkMapper from 'vtk.js/Sources/Rendering/Core/Mapper';
import vtkSTLReader from 'vtk.js/Sources/IO/Geometry/STLReader';
import vtkPointPicker from 'vtk.js/Sources/Rendering/Core/PointPicker';
import vtkSphereSource from 'vtk.js/Sources/Filters/Sources/SphereSource';
import vtkPolyData from 'vtk.js/Sources/Common/DataModel/PolyData';

// ----------------------------------------------------------------------------
// Example code
// ----------------------------------------------------------------------------

const reader = vtkSTLReader.newInstance();
const mesh = vtkPolyData.newInstance();
const mapper = vtkMapper.newInstance({ scalarVisibility: false });
const actor = vtkActor.newInstance();
const picker = vtkPointPicker.newInstance();


//mapper.setInputData(mesh);
mapper.setInputConnection(reader.getOutputPort());
actor.setMapper(mapper);
// ----------------------------------------------------------------------------

function update() {
  const fullScreenRenderer = vtkFullScreenRenderWindow.newInstance();
  const renderer = fullScreenRenderer.getRenderer();
  const renderWindow = fullScreenRenderer.getRenderWindow();

  const resetCamera = renderer.resetCamera;
  const render = renderWindow.render;

  picker.setPickFromList(1);
  picker.initializePickList();
  picker.addPickList(actor);

  // Pick on mouse right click
  renderWindow.getInteractor().onRightButtonPress((callData) => {
    if (renderer !== callData.pokedRenderer) {
      return;
    }
  
    const pos = callData.position;
    const point = [pos.x, pos.y, 0.0];
    console.log(`Pick at: ${point}`);
    picker.pick(point, renderer);
  
    if (picker.getActors().length === 0) {
      const pickedPoint = picker.getPickPosition();
      console.log(`No point picked, default: ${pickedPoint}`);
      const sphere = vtkSphereSource.newInstance();
      sphere.setCenter(pickedPoint);
      sphere.setRadius(0.01);
      const sphereMapper = vtkMapper.newInstance();
      sphereMapper.setInputData(sphere.getOutputData());
      const sphereActor = vtkActor.newInstance();
      sphereActor.setMapper(sphereMapper);
      sphereActor.getProperty().setColor(1.0, 0.0, 0.0);
      renderer.addActor(sphereActor);
    } else {
      const pickedPointId = picker.getPointId();
      console.log('Picked point: ', pickedPointId);
  
      const pickedPoints = picker.getPickedPositions();
      for (let i = 0; i < pickedPoints.length; i++) {
        const pickedPoint = pickedPoints[i];
        console.log(`Picked: ${pickedPoint}`);
        const sphere = vtkSphereSource.newInstance();
        sphere.setCenter(pickedPoint);
        sphere.setRadius(0.01);
        const sphereMapper = vtkMapper.newInstance();
        sphereMapper.setInputData(sphere.getOutputData());
        const sphereActor = vtkActor.newInstance();
        sphereActor.setMapper(sphereMapper);
        sphereActor.getProperty().setColor(0.0, 1.0, 0.0);
        renderer.addActor(sphereActor);
      }
    }
    renderWindow.render();
  });

  renderer.addActor(actor);
  resetCamera();
  render();
  
}

// ----------------------------------------------------------------------------
// Use a file reader to load a local file
// ----------------------------------------------------------------------------

const myContainer = document.querySelector('body');
const fileContainer = document.createElement('div');
fileContainer.innerHTML = '<input type="file" class="file"/>';
myContainer.appendChild(fileContainer);

const fileInput = fileContainer.querySelector('input');

function handleFile(event) {
  event.preventDefault();
  const dataTransfer = event.dataTransfer;
  const files = event.target.files || dataTransfer.files;
  if (files.length === 1) {
    myContainer.removeChild(fileContainer);
    const fileReader = new FileReader();
    fileReader.onload = function onLoad(e) {
      reader.parseAsArrayBuffer(fileReader.result);
      mesh = reader.getOutputData();
      update();
    };
    fileReader.readAsArrayBuffer(files[0]);
  }
}

fileInput.addEventListener('change', handleFile);


// -----------------------------------------------------------
// Make some variables global so that you can inspect and
// modify objects in your browser's developer console:
// -----------------------------------------------------------

global.mapper = mapper;
global.actor = actor;
global.renderer = renderer;
global.renderWindow = renderWindow;
global.picker = renderWindow.getInteractor().getPicker();
global.mesh = mesh;