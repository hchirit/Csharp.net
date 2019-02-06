package Elements;

import Primitives.*;
import java.awt.Color;
/**
 * Created by HC on 06/05/2017.
 */
public interface LightSource {
    public abstract Color getIntensity(Point3D point);
    public abstract Vector getL(Point3D point); // light to point vector
}
