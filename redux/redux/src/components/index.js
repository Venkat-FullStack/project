const redux = require('redux')
const createStore = redux.createStore
//Action
const BUY_CAKE = 'BUY_CAKE'

function buyCake() {
    return {
        type: BUY_CAKE,
        info: 'First redux action'
    }
}
//reducers  ]

const intialState = {
    numOfCakes: 10
}

const reducer = (state = intialState, action) => {
    switch (action.type) {
        case BUY_CAKE: return {
            ...state,
            numOfCakes: state.numOfCakes - 1
        }
        default: return state
    }
}
const store = createStore(reducer)