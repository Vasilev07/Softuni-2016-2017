function systemComponents(input) {
    let systemComponents = new Map();
    for (let info of input) {
        let [system, component, subcomponent] = info.split(' | ');
        if(!systemComponents.has(system)){
            systemComponents.set(system, new Map());
            systemComponents.get(system).set(component, []);
            systemComponents.get(system).get(component).push(subcomponent);
        }else if(!systemComponents.get(system).has(component)){
            systemComponents.get(system).set(component, []);
            systemComponents.get(system).get(component).push(subcomponent);
        }else {
            systemComponents.get(system).get(component).push(subcomponent);
        }
    }
    let sortedSystems = [...systemComponents.entries()].sort(firstSort)
    console.log(systemComponents)
    

}
systemComponents([
    'SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Securiti',
    'Indice | Session | Default Kor'
]);