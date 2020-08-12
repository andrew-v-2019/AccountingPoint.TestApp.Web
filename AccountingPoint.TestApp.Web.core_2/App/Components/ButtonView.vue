<template>
  <div class="button-view-container">
    <div class="loader" v-if="loading"></div>

    <div class="button-view-body">
      <div class="input-group mb-3">
        <div class="input-group-prepend">
          <span class="input-group-text" id="basic-addon1">@</span>
        </div>
        <input type="text" class="form-control" placeholder="Введите значение..." />
      </div>
    </div>
    <div class="button-view-footer">
      <small class="text-muted button-view-footer-label">View для {{button.title2}}</small>
    </div>
  </div>
</template>

<script>
import Service from "../Services/service.js";
/**Компонет отображения View для определённой кнопки */
export default {
  props: {
    button: {
      type: Object,
      required: true,
    },
  },

  data: function () {
    return {
      service: Service,
      loading: false,
    };
  },

  created: function () {
    this.getData();
  },

  methods: {
    /**
     *@description Обращение к сервису для запроса к backend'у
     */
    getData: function () {
      this.loading = true;
      this.service
        .getAll(this.button.id, this.button.delaySeconds)
        .then((r) => {
          this.loading = false;
        });
    },
  },
};
</script>