//grid_give_flatten_color_white
#version 330 core
layout (location=0) out vec4 color;
void main(){
    color = vec4(vec3(gl_FragCoord.z),1);
}