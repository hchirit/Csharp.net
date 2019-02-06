package Scene;

import java.awt.Color;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import Elements.AmbientLight;
import Elements.Camera;
import Elements.LightSource;
import Geometries.Geometry;
/**
 * Created by HC on 02/06/2017.
 */
public class Scene {
    private Color _background;
    private AmbientLight _ambientLight;
    private List<Geometry> _geometries = new ArrayList<Geometry>();
    private Camera _camera;
    private double _screenDistance;
    private List<LightSource> _lights = new ArrayList<LightSource>();
    private String _sceneName = "scene";
    // ***************** Constructors ********************** //
    public Scene(){
        _background=new Color(0);
        _ambientLight=new AmbientLight();
        _camera=new Camera();
        _screenDistance=100;
    }
    public Scene (Scene scene){
        _background=scene.getBackground();
        _ambientLight=scene.getAmbientLight();
        _geometries=scene._geometries;
        _camera=scene.getCamera();
        _screenDistance=scene.getScreenDistance();
        _lights=scene._lights;
    }
    public Scene(AmbientLight aLight, Color background,
                 Camera camera, double screenDistance){
        _ambientLight=aLight;
        _background=background;
        _camera=camera;
        _screenDistance=screenDistance;
    }

    // ***************** Getters/Setters ********************** //
    public Color getBackground(){return _background;}
    public AmbientLight getAmbientLight(){return new AmbientLight(_ambientLight);}
    public Camera getCamera(){return new Camera(_camera);}
    public String getSceneName(){return _sceneName;}
    public double getScreenDistance(){return _screenDistance;}

    public void setBackground(Color background){_background=background;}
    public void setAmbientLight(AmbientLight ambientLight){_ambientLight=new AmbientLight(ambientLight);}
    public void setCamera(Camera camera){_camera= new Camera(camera);}
    public void setSceneName(String sceneName){_sceneName=sceneName;}
    public void setScreenDistance(double screenDistance){_screenDistance=screenDistance;}

    // ***************** Operations ******************** //

    public void addGeometry(Geometry geometry){_geometries.add(geometry);}
    public Iterator<Geometry> getGeometriesIterator(){return _geometries.iterator();}
    public void addLight(LightSource light){_lights.add(light);}
    public Iterator<LightSource> getLightsIterator(){return _lights.iterator();}

    public void clearAllGeometry(){ _geometries.clear(); }

}
